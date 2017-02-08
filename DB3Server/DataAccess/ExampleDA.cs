//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.OleDb;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DB3Server.DataAccess
//{
//    class ExampleDA
//    {
//        internal class DAChannel
//        {
//            /// <summary>
//            /// Gets the channels.
//            /// </summary>
//            /// <returns></returns>
//            internal static DataTable GetChannels()
//            {
//                DBCommand cmd = new DBCommand("cas_channel_sel");
//                DataTable dt = cmd.GetDataTable();
//                return dt;
//            }

//            /// <summary>
//            /// Gets data for specified channel.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            /// <returns></returns>
//            internal static DataTable Get(int channelId)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_sel");
//                cmd.AddParam("@channel_id", channelId);
//                DataTable dt = cmd.GetDataTable();

//                return dt;
//            }

//            /// <summary>
//            /// Inserts the specified channel.
//            /// </summary>
//            /// <param name="name">The name.</param>
//            /// <param name="primeConnectionId">The prime connection identifier.</param>
//            /// <param name="secondConnectionId">The second connection identifier.</param>
//            /// <param name="winccVersion">The wincc version.</param>
//            /// <param name="channelType">Type of the channel.</param>
//            /// <returns>
//            /// Inserted record ID
//            /// </returns>
//            internal static int Insert(string name, int primeConnectionId, int? secondConnectionId, int winccVersion, byte channelType)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_ins_upd");
//                cmd.AddParam("@name", name);
//                cmd.AddParam("@prime_connection_id", primeConnectionId);
//                if (secondConnectionId.HasValue)
//                    cmd.AddParam("@second_connection_id", secondConnectionId.Value);
//                cmd.AddParam("@wincc_version", winccVersion);
//                cmd.AddParam("@channel_type", channelType);

//                return (int)cmd.ExecuteScalar();
//            }

//            /// <summary>
//            /// Updates the specified channel.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            /// <param name="name">The name.</param>
//            /// <param name="secondConnectionId">The second connection identifier.</param>
//            /// <param name="winccVersion">The wincc version.</param>
//            /// <returns> Updated record ID </returns>
//            internal static int Update(int channelId, string name, int? secondConnectionId, int winccVersion, byte channelType)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_ins_upd");
//                cmd.AddParam("@channel_id", channelId);
//                cmd.AddParam("@name", name);
//                if (secondConnectionId.HasValue)
//                    cmd.AddParam("@second_connection_id", secondConnectionId);
//                cmd.AddParam("@wincc_version", winccVersion);
//                cmd.AddParam("@channel_type", channelType);
//                return (int)cmd.ExecuteScalar();
//            }

//            /// <summary>
//            /// Deletes the specified channel.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            internal static void Delete(int channelId)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_del");
//                cmd.AddParam("@channel_id", channelId);

//                cmd.ExecuteNonQuery();
//            }

//            /// <summary>
//            /// Updates the last tags synchronize date time.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            /// <param name="dateTime">The date time.</param>
//            internal static void UpdateLastTagsSyncDateTime(int channelId, DateTime dateTime)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_tag_sync_upd");
//                cmd.AddParam("@channel_id", channelId);
//                cmd.AddParam("@last_tag_sync", dateTime);

//                cmd.ExecuteNonQuery();
//            }

//            /// <summary>
//            /// Updates the last alarms read date time.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            /// <param name="dateTime">The date time.</param>
//            internal static void UpdateLastAlarmsReadDateTime(int channelId, DateTime dateTime)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_alarm_read_upd");
//                cmd.AddParam("@channel_id", channelId);
//                cmd.AddParam("@last_alarm_read", dateTime);

//                cmd.ExecuteNonQuery();
//            }

//            /// <summary>
//            /// Updates the is no area archived.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            /// <param name="isNoAreaArchived">if set to <c>true</c> [is no area archived].</param>
//            internal static void UpdateIsNoAreaArchived(int channelId, bool isNoAreaArchived)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_no_area_archived_upd");
//                cmd.AddParam("@channel_id", channelId);
//                cmd.AddParam("@is_no_area_archived", isNoAreaArchived);

//                cmd.ExecuteNonQuery();
//            }

//            /// <summary>
//            /// Updates the win cc version.
//            /// </summary>
//            /// <param name="channelId">The channel identifier.</param>
//            /// <param name="winccVersion">The wincc version.</param>
//            internal static void UpdateWinCcVersion(int channelId, int winccVersion)
//            {
//                DBCommand cmd = new DBCommand("cas_channel_wincc_version_upd");
//                cmd.AddParam("@channel_id", channelId);
//                cmd.AddParam("@wincc_version", winccVersion);

//                cmd.ExecuteNonQuery();
//            }

//            /// <summary>
//            /// Tests the SQL OLE database connection.
//            /// </summary>
//            /// <param name="serverName">Name of the server.</param>
//            /// <param name="initialCatalog">The initial catalog.</param>
//            /// <param name="userId">The user identifier.</param>
//            /// <param name="password">The password.</param>
//            /// <param name="isSqlAuthentication">if set to <c>true</c> [is SQL authentication].</param>
//            /// <exception cref="ExpectedException"></exception>
//            internal static void TestSqlOleDbConnection(String serverName, String initialCatalog, String userId, String password, bool isSqlAuthentication)
//            {
//                var connectionString = isSqlAuthentication ?
//                    String.Format("Provider=SQLOLEDB; Data Source={0}; Initial Catalog={1}; uid={2}; pwd={3};",
//                        serverName, initialCatalog, userId, password) :
//                    String.Format("Provider=SQLOLEDB; Data Source={0}; Initial Catalog={1}; Integrated Security=SSPI;",
//                        serverName, initialCatalog);

//                var conn = new OleDbConnection(connectionString);

//                try
//                {
//                    conn.Open();
//                }
//                catch (OleDbException)
//                {
//                    throw new ExpectedException(ExpectedErrors.ErrorCodes.CONNECTION_WITH_SQL_PROVIDER_FAIELD);
//                }
//                finally
//                {
//                    conn.Close();
//                }
//            }

//            /// <summary>
//            /// Tests the WinCC connection.
//            /// </summary>
//            /// <param name="provider">The provider.</param>
//            /// <param name="serverName">Name of the server.</param>
//            /// <param name="initialCatalog">The initial catalog.</param>
//            /// <exception cref="ExpectedException"></exception>
//            internal static void TestWinCcConnection(string provider, string serverName, string initialCatalog)
//            {
//                var connectionString = String.Format("Provider={0}; Data Source={1}; Catalog={2};", provider, serverName, initialCatalog);

//                var conn = new OleDbConnection(connectionString);

//                try
//                {
//                    conn.Open();
//                }
//                catch (Exception)
//                {
//                    //if (ex.Message.Equals("The 'WinCCOLEDBProvider.1' provider is not registered on the local machine."))
//                    throw new ExpectedException(ExpectedErrors.ErrorCodes.CONNECTION_WITH_WINCC_PROVIDER_FAILED);
//                }
//                finally
//                {
//                    conn.Close();
//                }
//            }
//        }
//}
