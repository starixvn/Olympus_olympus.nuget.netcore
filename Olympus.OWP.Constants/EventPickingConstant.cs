using System.Collections.Generic;
using System.Collections.Immutable;

namespace Olympus.OWP.Constants
{
    public static class UpdateTypeConstant
    {
        public const short NEW_MATCH = 1;
        public const short UPDATE_KO_TIME = 2;
        public const short UPDATE_LEAGUE = 3;
        public const short UPDATE_TEAM = 4;
        public const short UPDATE_TV = 5;
        public const short CANCEL_TV = 6;
        public const short UPDATE_IPTV = 7;
        public const short CANCEL_IPTV = 8;
        public const short UPDATE_OTHER_PROVIDER = 9;
        public const short CANCEL_OTHER_PROVIDER = 10;
        public const short DELETE_MATCH = 11;
        public const short UPDATE_ROUND = 12;
        public const short CANCEL_ROUND = 13;
        public const short UPDATE_ROUND_HAT = 14;
        public const int CANCEL_ROUND_HAT = 15;
        public const short UPDATE_REMARK = 16;
        public const short CANCEL_REMARK = 17;
        public const short UPDATE_HOME_REMARK = 18;
        public const short CANCEL_HOME_REMARK = 19;
        public const short UPDATE_AWAY_REMARK = 20;
        public const short CANCEL_AWAY_REMARK = 21;
        public const short UPDATE_DIVISION = 22;
        public const short CANCEL_DIVISION = 23;
        public const short MOVE_KICKOFF_DATE = 24;
        public const short RENEW_MATCH = 25;
        public const short MATCH_POSTPONED = 26;
        public const short MATCH_CANCELLED = 27;
        public const short UPDATE_ROUND_CONFIRM = 28;
        public const short CANCEL_ROUND_CONFIRM = 29;
        public const short UPDATE_ADMINSITEID = 30;
        public const short CANCEL_ADMINSITEID = 31;
        public const short UPDATE_WEB1 = 32;
        public const short CANCEL_WEB1 = 33;
        public const short UPDATE_WEB2 = 34;
        public const short CANCEL_WEB2 = 35;
        public const short UPDATE_WEB3 = 36;
        public const short CANCEL_WEB3 = 37;
        public const short UPDATE_WEB4 = 38;
        public const short CANCEL_WEB4 = 39;
        public const short UPDATE_LINK = 40;
        public const short CANCEL_LINK = 41;
        public const short UPDATE_CHANNEL = 42;
        public const short CANCEL_CHANNEL = 43;
        public const short UPDATE_AGENT = 44;
        public const short CANCEL_AGENT = 45;
        public const short UPDATE_VENUE = 46;
        public const short CANCEL_VENUE = 47;
        public const short UPDATE_ETPK = 48;
        public const short CANCEL_ETPK = 49;
        public const short UPDATE_NEUTRAL = 50;
        public const short CANCEL_NEUTRAL = 51;
        public const short MATCH_SUSPENDED = 52;
        public const short UPDATE_REMARK2 = 53;
        public const short CANCEL_REMARK2 = 54;
        public const short UPDATE_PROVIDER = 55;
        public const short CANCEL_PROVIDER = 56;
        public const short UPDATE_TOTAL_ROUND = 57;
        public const short CANCEL_TOTAL_ROUND = 58;
        public const short UPDATE_HOME_BAD_RANKING = 59;
        public const short UPDATE_AWAY_BAD_RANKING = 60;
        public const short UPDATE_HOME_RELEGATION = 61;
        public const short UPDATE_AWAY_RELEGATION = 62;
        public const short UPDATE_MATCH_OFFER = 63;

        public static readonly IImmutableDictionary<int, string> UpdateType = new Dictionary<int, string>
        {
            { NEW_MATCH, "Add a new match" },
            { UPDATE_KO_TIME, "Update the <b>KO time</b>" },
            { UPDATE_LEAGUE, "Update the <b>League name</b>" },
            { UPDATE_TEAM, "Update the <b>Team name</b>" },
            { UPDATE_TV, "Update the <b>TV</b>" },
            { CANCEL_TV, "Cancel the <b>TV</b>" },
            { UPDATE_IPTV, "Update the <b>IPTV</b>" },
            { CANCEL_IPTV, "Cancel the <b>IPTV</b>" },
            { UPDATE_OTHER_PROVIDER, "Update the <b>Other Provider</b>" },
            { CANCEL_OTHER_PROVIDER, "Cancel the <b>Other Provider</b>" },
            { DELETE_MATCH, "Delete the match" },
            { UPDATE_ROUND, "Update the <b>Round</b>" },
            { CANCEL_ROUND, "Cancel the <b>Round</b>" },
            { UPDATE_ROUND_HAT, "Update the <b>Round (H-A/T)</b>" },
            { CANCEL_ROUND_HAT, "Cancel the <b>Round (H-A/T)</b>" },
            { UPDATE_REMARK, "Update the <b>Remark</b>" },
            { CANCEL_REMARK, "Cancel the <b>Remark</b>" },
            { UPDATE_HOME_REMARK, "Update the <b>Home Remark</b>" },
            { CANCEL_HOME_REMARK, "Cancel the <b>Home Remark</b>" },
            { UPDATE_AWAY_REMARK, "Update the <b>Away Remark</b>" },
            { CANCEL_AWAY_REMARK, "Cancel the <b>Away Remark</b>" },
            { UPDATE_DIVISION, "Update the <b>Division</b>" },
            { CANCEL_DIVISION, "Cancel the <b>Division</b>" },
            { MOVE_KICKOFF_DATE, "Move <b>KO Date</b>" },
            { RENEW_MATCH, "Renew Match" },
            { MATCH_POSTPONED, "Match <b>Postponed</b>" },
            { MATCH_CANCELLED, "Match <b>Cancelled</b>" },
            { UPDATE_ROUND_CONFIRM, "Update the <b>Round Confirm</b>" },
            { CANCEL_ROUND_CONFIRM, "Cancel the <b>Round Confirm</b>" },
            { UPDATE_ADMINSITEID, "Update the <b>AdminSiteID</b>" },
            { CANCEL_ADMINSITEID, "Cancel the <b>AdminSiteID</b>" },
            { UPDATE_WEB1, "Update the <b>Web1</b>" },
            { CANCEL_WEB1, "Cancel the <b>Web1</b>" },
            { UPDATE_WEB2, "Update the <b>Web2</b>" },
            { CANCEL_WEB2, "Cancel the <b>Web2</b>" },
            { UPDATE_WEB3, "Update the <b>Web3</b>" },
            { CANCEL_WEB3, "Cancel the <b>Web3</b>" },
            { UPDATE_WEB4, "Update the <b>Web4</b>" },
            { CANCEL_WEB4, "Cancel the <b>Web4</b>" },
            { UPDATE_LINK, "Update the <b>Link</b>" },
            { CANCEL_LINK, "Cancel the <b>Link</b>" },
            { UPDATE_CHANNEL, "Update the <b>Channel</b>" },
            { CANCEL_CHANNEL, "Cancel the <b>Channel</b>" },
            { UPDATE_AGENT, "Update the <b>Agent</b>" },
            { CANCEL_AGENT, "Cancel the <b>Agent</b>" },
            { UPDATE_VENUE, "Update the <b>Venue</b>" },
            { CANCEL_VENUE, "Cancel the <b>Venue</b>" },
            { UPDATE_ETPK, "Update the <b>ETPK</b>" },
            { CANCEL_ETPK, "Cancel the <b>ETPK</b>" },
            { UPDATE_NEUTRAL, "Update the <b>Neutral</b>" },
            { CANCEL_NEUTRAL, "Cancel the <b>Neutral</b>" },
            { MATCH_SUSPENDED, "Match <b>Suspended</b>" },
            { UPDATE_REMARK2, "Update the <b>Remark2</b>" },
            { CANCEL_REMARK2, "Cancel the <b>Remark2</b>" },
            { UPDATE_PROVIDER, "Update the <b>Provider</b>" },
            { CANCEL_PROVIDER, "Cancel the <b>Provider</b>" },
            { UPDATE_TOTAL_ROUND, "Update the <b>Total Round</b>" },
            { CANCEL_TOTAL_ROUND, "Cancel the <b>Total Round</b>" },
            { UPDATE_HOME_BAD_RANKING , "Update the <b>Home Bad Ranking</b>" },
            { UPDATE_AWAY_BAD_RANKING , "Update the <b>Away Bad Ranking</b>" },
            { UPDATE_HOME_RELEGATION, "Update the <b>Home Relegation</b>" },
            { UPDATE_AWAY_RELEGATION, "Update the <b>Away Relegation</b>" },
            { UPDATE_MATCH_OFFER , "Update the <strong>Match Offer</strong>" }
        }.ToImmutableDictionary();
    }
}
