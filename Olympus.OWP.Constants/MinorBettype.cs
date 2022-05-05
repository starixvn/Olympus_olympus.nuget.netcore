namespace Olympus.OWP.Constants
{
    using System.Collections.Generic;
    using System.Linq;

    public static class MinorBettype
    {
        public const int Specific15Min = -1;
        public const int Specific10Min = -2;
        public const int NoOfCorners = -3;
        public const int NextCorners = -4;
        public const int FifteenMinsNoOfCorners = -5;
        public const int TotalBooking = -6;
        public const int NextBooking = -7;
        public const int FifteenMinsTotalBooking = -8;
        public const int PenatyShootOutTeamFirstPen = -11;
        public const int BronzeMedalWinner = -12;
        public const int GoldMedalWinner = -13;
        public const int Winner = -14;
        public const int AdvanceToNextRound = -15;
        public const int LastCorners = -90;
        public const int LastBooking = -91;
        public const int HomeSingleTeamOU = -92;
        public const int AwaySingleTeamOU = -93;
        public const int HomeSingleTeamOUCorners = -94;
        public const int AwaySingleTeamOUCorners = -95;
        public const int FirstPenatyScore = -96;
        public const int FirstPenatyAwarded = -97;
        public const int PenShootOut = -98;
        public const int PenatyShootOut = -99;
        public const int NextGoalKick = -100;
        public const int LastGoalKick = -101;
        public const int SecondH1stGoalKick = -102;
        public const int LastOffside = -103;
        public const int SecondH1stOffside = -104;
        public const int LastThrowIn = -105;
        public const int SecondH1stThrowIn = -106;
        public const int LastFreeKick = -107;
        public const int SecondH1stFreeKick = -108;
        public const int NextGoal = -109;

        private static readonly Dictionary<int, int> MinorBettypeMap = new Dictionary<int, int>
        {
            {Specific15Min, 1800},
            {Specific10Min, 1900},
            {NoOfCorners, 2000},
            {NextCorners, 2100},
            {FifteenMinsNoOfCorners, 2700},
            {TotalBooking, 2800},
            {NextBooking, 2900},
            {FifteenMinsTotalBooking, 3500},
            {PenatyShootOutTeamFirstPen, 1200},
            {Winner, 600},
            {AdvanceToNextRound, 800},
            {LastCorners, 2300},
            {LastBooking, 3100},
            {HomeSingleTeamOU, 1601},
            {AwaySingleTeamOU, 1602},
            {HomeSingleTeamOUCorners, 2401},
            {AwaySingleTeamOUCorners, 2402},
            {FirstPenatyScore, 5800},
            {FirstPenatyAwarded, 5700},
            {PenShootOut, 1100},
            {PenatyShootOut, 1150},
            {NextGoalKick, 3900},
            {LastGoalKick, 4100},
            {SecondH1stGoalKick, 4000},
            {LastOffside, 4600},
            {SecondH1stOffside, 4500},
            {LastThrowIn, 4900},
            {SecondH1stThrowIn, 4800},
            {LastFreeKick, 5400},
            {SecondH1stFreeKick, 5300},
            {NextGoal, 400},
        };

        public static int GetRepresentativeSubtype(int bettypeId)
        {
            var isSubtype = MinorBettypeMap.ContainsKey(bettypeId);
            return isSubtype ? MinorBettypeMap[bettypeId] : 0;
        }

        public static int GetMinorBettypeIdBySubtype(int subtype)
            => MinorBettypeMap
                .FirstOrDefault(x => x.Value == subtype).Key;
    }
}