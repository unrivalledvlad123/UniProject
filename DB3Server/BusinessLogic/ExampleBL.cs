using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB3Server.BusinessLogic
{
    class ExampleBL
    {

        public List<int> GetAllServers(string host)
        {

            OpcConnection con = new OpcConnection();
            var servers = con.BrowseServers(host);
            return servers;
        }

        #region < ========== Subscribe Methods ========== >

      public static void SubscribeToMany()
        {
            PopulateOpcTagsData();
            List<KeyValuePair<string, string>> tagAdressCollection = TagAdressList(BLTag.GetAllUsedOpcTags());
            ArrayList list = new ArrayList();
            foreach (var element in tagAdressCollection)
            {
                string opcAddress = $"{element.Key}\\{element.Value}";
                if (!CASServer.CurrentlySubscribedTags.Contains(opcAddress))
                {
                    CASServer.CurrentlySubscribedTags.Add(opcAddress);
                    try
                    {
                        list.Add(new EasyUAMonitoredItemArguments(null, element.Key,
                            element.Value, 1 * 1000));
                    }
                    catch (OpcLabs.EasyOpc.UA.Parsing.UANodeIdFormatException e)
                    {
                        Log.AddMessage("Error at: " + opcAddress + " Error code: " + e.Message, LogType.ErrorMsgs);
                    }
                }
            }
            CASServer.OpcClient.DataChangeNotification -= easyUAClient_DataChangeNotificationMany;
            CASServer.OpcClient.DataChangeNotification += easyUAClient_DataChangeNotificationMany;
            CASServer.OpcClient.SubscribeMultipleMonitoredItems(
                (EasyUAMonitoredItemArguments[])list.ToArray(typeof(EasyUAMonitoredItemArguments)));
        }

        static void easyUAClient_DataChangeNotificationMany(object sender, EasyUADataChangeNotificationEventArgs e)
        {
            List<OpcTags> tagsData = GetOpcTagsData(BLTag.GetAllUsedOpcTags());
            string opcAddress = $"{e.Arguments.EndpointDescriptor}\\{e.Arguments.NodeDescriptor}";

            if (e.Succeeded)
            {
                List<OpcTags> sincTagsPrimary = tagsData.FindAll(s => s.PrimaryAdress == opcAddress).ToList();
                List<OpcTags> sincTagsSecondary = tagsData.FindAll(s => s.SecondaryAdress == opcAddress).ToList();

                if (e.AttributeData?.Value != null && IsNumeric(e.AttributeData.Value))
                {
                    float value;
                    int quality;
                    var value1 = e.AttributeData.Value.ToString();
                    var quality1 = e.AttributeData.StatusCode.InternalValue.ToString();
                    float.TryParse(value1, out value);
                    int.TryParse(quality1, out quality);
                    if (quality == 0)
                    {
                        quality = 0x80;
                    }
                    RSRTWinCcTag element = new RSRTWinCcTag
                    {
                        Value = value,
                        Quality = quality,
                        Time = DateTime.UtcNow
                    };
                    foreach (var sincTag in sincTagsPrimary)
                    {
                        OpcTags sincTagData = CASServer.AllSubscribedTags.FirstOrDefault(p => p.ID == sincTag.ID);
                        if (sincTag.PrimaryAdress != null)
                        {
                            if (CASServer.OpcValues.ContainsKey(sincTag.ID) && sincTag.PrimaryAdress != opcAddress)
                            {
                                if (sincTagData != null)
                                    sincTagData.PrimaryAdress = opcAddress;
                            }
                            else if (CASServer.OpcValues.ContainsKey(sincTag.ID))
                            {
                                List<RSRTWinCcTag> elements = CASServer.OpcValues[sincTag.ID];
                                elements.Add(element);
                                CASServer.OpcValues[sincTag.ID] = elements;
                            }
                            else
                            {
                                try
                                {
                                    CASServer.OpcValues.Add(sincTag.ID, new List<RSRTWinCcTag> { element });
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    foreach (var sincTag in sincTagsSecondary)
                    {
                        OpcTags sincTagData = CASServer.AllSubscribedTags.FirstOrDefault(p => p.ID == sincTag.ID);
                        if (sincTag.SecondaryAdress != null)
                        {
                            if (CASServer.OpcValues.ContainsKey(sincTag.ID) && sincTag.SecondaryAdress != opcAddress)
                            {
                                if (sincTagData != null)
                                    sincTagData.SecondaryAdress = opcAddress;
                            }
                            else if (CASServer.OpcValues.ContainsKey(sincTag.ID))
                            {
                                List<RSRTWinCcTag> elements = CASServer.OpcValues[sincTag.ID];
                                elements.Add(element);
                                CASServer.OpcValues[sincTag.ID] = elements;
                            }
                            else
                            {
                                CASServer.OpcValues.Add(sincTag.ID, new List<RSRTWinCcTag> { element });
                            }
                        }
                    }
                }
            }
        }

        public static bool IsNumeric(object expression)
        {
            double retNum;
            bool isNum = double.TryParse(Convert.ToString(expression), System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static List<OpcTags> GetOpcTagsData(List<RSTag> tags)
        {
            List<OpcTags> tagList = new List<OpcTags>();
            List<RSChannel> allChannels = BLChannel.ListChannels();
            foreach (RSTag tag in tags)
            {
                string conncatSecondaryAddres = "";
                RSChannel tagChannel = allChannels.FirstOrDefault(p => p.ChannelID == tag.ChannelID);
                if (tagChannel == null)
                    continue;
                string conncatPrimaryAddres = $"{tagChannel.PrimeConnection.WinCCProvider}\\{tag.PrimaryAddress}";
                if (!string.IsNullOrEmpty(tag.SecondaryAddress) && tagChannel.SecondConnection != null)
                {
                    conncatSecondaryAddres = $"{tagChannel.SecondConnection.WinCCProvider}\\{tag.SecondaryAddress}";
                }
                OpcTags tagElement = new OpcTags();
                if (tag.TagID != null) tagElement.ID = (int)tag.TagID;
                tagElement.PrimaryAdress = conncatPrimaryAddres;
                tagElement.SecondaryAdress = conncatSecondaryAddres;
                tagList.Add(tagElement);
            }
            return tagList;
        }

        public static void PopulateOpcTagsData()
        {
            List<RSTag> tags = BLTag.GetAllUsedOpcTags();
            List<RSChannel> allChannels = BLChannel.ListChannels();
            foreach (RSTag tag in tags)
            {
                string conncatSecondaryAddres = "";
                RSChannel tagChannel = allChannels.FirstOrDefault(p => p.ChannelID == tag.ChannelID);
                if (tagChannel == null)
                    continue;
                string conncatPrimaryAddres = $"{tagChannel.PrimeConnection.WinCCProvider}\\{tag.PrimaryAddress}";
                if (!string.IsNullOrEmpty(tag.SecondaryAddress) && tagChannel.SecondConnection != null)
                {
                    conncatSecondaryAddres = $"{tagChannel.SecondConnection.WinCCProvider}\\{tag.SecondaryAddress}";
                }
                OpcTags tagElement = new OpcTags();
                if (tag.TagID != null) tagElement.ID = (int)tag.TagID;
                tagElement.PrimaryAdress = conncatPrimaryAddres;
                tagElement.SecondaryAdress = conncatSecondaryAddres;
                var v = CASServer.AllSubscribedTags.FirstOrDefault(p => p.ID == tag.TagID);
                if (v == null)
                {
                    CASServer.AllSubscribedTags.Add(tagElement);
                }
            }
        }

        public static List<KeyValuePair<string, string>> TagAdressList(List<RSTag> tags)
        {
            List<KeyValuePair<string, string>> results = new List<KeyValuePair<string, string>>();
            List<RSChannel> allChannels = BLChannel.ListChannels();
            foreach (RSTag tag in tags)
            {
                RSChannel tagChannel = allChannels.FirstOrDefault(p => p.ChannelID == tag.ChannelID);
                if (tagChannel == null)
                {
                    continue;
                }
                results.Add(new KeyValuePair<string, string>(tagChannel.PrimeConnection.WinCCProvider,
                    tag.PrimaryAddress));

                if (!string.IsNullOrEmpty(tag.SecondaryAddress) && tagChannel.SecondConnection != null)
                {
                    results.Add(new KeyValuePair<string, string>(tagChannel.SecondConnection.WinCCProvider,
                        tag.SecondaryAddress));
                }
            }
            return results;
        }

        #endregion

        #region < ========== Resubscribe Methods ========== >

        public static void CheckOpcChannelsActivity()
        {
            TestOpcConnection();
            List<RSTag> tagsToBeSubscribed = TagsToBeSubscribed();
            List<OpcChannelState> opcChannelState = CASServer.OpcChannelState;
            if (tagsToBeSubscribed.Count != 0)
            {
                foreach (var tag in tagsToBeSubscribed)
                {
                    if (tag.TagID != null && CASServer.OpcValues.ContainsKey((int)tag.TagID))
                    {
                        CASServer.OpcValues.Remove((int)tag.TagID);
                    }
                }
            }
            foreach (var channel in opcChannelState)
            {
                if (channel.IsConnectionOk && channel.IsConnectionOkPrevious == false)
                {
                    CASServer.CurrentlySubscribedTags.Clear();
                    CASServer.OpcClient.UnsubscribeAllMonitoredItems();
                    System.Threading.Thread.Sleep(2 * 1000);
                    SubscribeToMany();
                    Log.AddMessage("< ============= Trying to resubscribe ============= > ",
                        LogType.ResubscribeAttempts);
                    break;
                }
            }
        }

        public static void ManualResuscribeAll()
        {
            CASServer.CurrentlySubscribedTags.Clear();
            CASServer.OpcClient.UnsubscribeAllMonitoredItems();
            System.Threading.Thread.Sleep(2 * 1000);
            //  SubscribeToMany();
            Log.AddMessage("< ============= Manual Resubscribe ============= > ", LogType.ResubscribeAttempts);
        }

        public static List<OpcChannelState> TestOpcConnection()
        {
            EasyUAClient client = CASServer.OpcClient;
            List<RSTag> allTags = BLTag.GetAllUsedOpcTags();
            List<RSChannel> allChannels = BLChannel.ListChannels();
            List<OpcChannelState> opcConnectionTestFlag = CASServer.OpcChannelState;
            foreach (var channel in allChannels)
            {
                if (channel.ChannelType == ChannelType.OPC)
                {
                    bool flag = false;
                    DateTime time = DateTime.Now;
                    ArrayList tagsToBeRead = new ArrayList();
                    List<RSTag> allTagsOnTheChannel = allTags.FindAll(p => p.ChannelID == channel.ChannelID).ToList();
                    foreach (var tag in allTagsOnTheChannel)
                    {
                        if (channel.PrimeConnection != null && tag.PrimaryAddress != null)
                            tagsToBeRead.Add(new UAReadArguments(channel.PrimeConnection.WinCCProvider,
                                tag.PrimaryAddress));
                        if (channel.SecondConnection != null && tag.SecondaryAddress != null)
                            tagsToBeRead.Add(new UAReadArguments(channel.SecondConnection.WinCCProvider,
                                tag.SecondaryAddress));
                    }
                    var sincedFlag = opcConnectionTestFlag.FirstOrDefault(p => p.ChannelId == channel.ChannelID);
                    UAAttributeDataResult[] attributeDataResultArray =
                        client.ReadMultiple((UAReadArguments[])tagsToBeRead.ToArray(typeof(UAReadArguments)));
                    foreach (UAAttributeDataResult attributeDataResult in attributeDataResultArray)
                    {
                        try
                        {
                            // useless var for checking, do not delete!
                            // ReSharper disable once UnusedVariable
                            var uselessVarForCheck = attributeDataResult.AttributeData.Value;
                            if (sincedFlag == null && flag == false)
                            {
                                time = DateTime.Now;
                                flag = true;
                            }
                            else if (sincedFlag != null && sincedFlag.IsConnectionOk == false)
                            {
                                time = DateTime.Now;
                                flag = true;
                            }
                            else if (sincedFlag != null && sincedFlag.IsConnectionOk)
                            {
                                flag = true;
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            if (sincedFlag == null && flag == false)
                            {
                                time = DateTime.Now;
                                flag = false;
                            }
                            else if (sincedFlag != null && sincedFlag.IsConnectionOk)
                            {
                                time = DateTime.Now;
                                flag = false;
                            }
                            else if (sincedFlag != null && sincedFlag.IsConnectionOk == false)
                            {
                                flag = false;
                            }
                            //  break;
                        }
                    }
                    if (sincedFlag != null)
                    {
                        if (sincedFlag.IsConnectionOk != flag)
                        {
                            sincedFlag.IsConnectionOkPrevious = sincedFlag.IsConnectionOk;
                            sincedFlag.IsConnectionOk = flag;
                            sincedFlag.LatestChange = time;
                            //Log.AddMessage("Channel id: " + channel.ChannelID + ", Channel connection: " +
                            //               channel.PrimeConnection.WinCCProvider + " : current flag state: " +
                            //               ConvertFromBoolToState(flag));
                        }
                        else if (sincedFlag.IsConnectionOk == flag)
                        {
                            sincedFlag.IsConnectionOkPrevious = sincedFlag.IsConnectionOk;
                            //Log.AddMessage("Channel id: " + channel.ChannelID + ", Channel connection: " +
                            //               channel.PrimeConnection.WinCCProvider + " : current flag state: " +
                            //               ConvertFromBoolToState(flag));
                        }
                    }
                    else
                    {
                        opcConnectionTestFlag.Add(new OpcChannelState
                        {
                            ChannelId = channel.ChannelID,
                            IsConnectionOk = flag,
                            IsConnectionOkPrevious = flag,
                            LatestChange = time
                        });
                        //Log.AddMessage("Channel id: " + channel.ChannelID + ", Channel connection: " +
                        //               channel.PrimeConnection.WinCCProvider + " : current flag state: " +
                        //               ConvertFromBoolToState(flag));
                    }
                }
            }

            return opcConnectionTestFlag;
        }

        public static List<RSTag> TagsToBeSubscribed()
        {
            List<OpcChannelState> opcTestConnectionFlag = CASServer.OpcChannelState;
            List<RSTag> allTags = BLTag.GetAllUsedOpcTags();
            List<RSTag> tagsToBeSubscribed = new List<RSTag>();
            foreach (var flag in opcTestConnectionFlag)
            {
                if (flag.IsConnectionOk == false)
                {
                    List<RSTag> tagsToBeSubscribedInTheChannel =
                        allTags.FindAll(p => p.ChannelID == flag.ChannelId).ToList();
                    tagsToBeSubscribed.AddRange(tagsToBeSubscribedInTheChannel);
                }
            }
            return tagsToBeSubscribed;
        }

        #endregion

        public static string ConvertFromBoolToState(bool state)
        {
            return state ? "Active" : "Inactive";
        }
    }
}
