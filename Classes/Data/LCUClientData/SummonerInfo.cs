using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Acccount_Manager.Classes.Data.LCUClientData
{
    public class SummonerInfo
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public DateTime DateAdded { get; set; }
        public string Tier { get; set; }
        public string Division { get; set; }
        public int LeaguePoints { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int? DaysUntilDecay { get; set; }
        public bool Provisional { get; set; }
    }

    public class HighestRankedEntry
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public Warnings warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }
    }

    public class HighestRankedEntrySR
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public Warnings warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }
    }

    public class Queue
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public Warnings warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }
    }

    public class QueueMap
    {
        [JsonProperty("RANKED_FLEX_SR")]
        public RANKEDFLEXSR RANKED_FLEX_SR { get; set; }

        [JsonProperty("RANKED_SOLO_5x5")]
        public RANKEDSOLO5x5 RANKED_SOLO_5x5 { get; set; }

        [JsonProperty("RANKED_TFT")]
        public RANKEDTFT RANKED_TFT { get; set; }

        [JsonProperty("RANKED_TFT_DOUBLE_UP")]
        public RANKEDTFTDOUBLEUP RANKED_TFT_DOUBLE_UP { get; set; }

        [JsonProperty("RANKED_TFT_PAIRS")]
        public RANKEDTFTPAIRS RANKED_TFT_PAIRS { get; set; }

        [JsonProperty("RANKED_TFT_TURBO")]
        public RANKEDTFTTURBO RANKED_TFT_TURBO { get; set; }
    }

    public class RANKEDFLEXSR
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public object warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("currentSeasonEnd")]
        public long currentSeasonEnd { get; set; }

        [JsonProperty("currentSeasonId")]
        public int currentSeasonId { get; set; }

        [JsonProperty("nextSeasonStart")]
        public int nextSeasonStart { get; set; }
    }

    public class RANKEDSOLO5x5
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public Warnings warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("currentSeasonEnd")]
        public long currentSeasonEnd { get; set; }

        [JsonProperty("currentSeasonId")]
        public int currentSeasonId { get; set; }

        [JsonProperty("nextSeasonStart")]
        public int nextSeasonStart { get; set; }
    }

    public class RANKEDTFT
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public object warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("currentSeasonEnd")]
        public long currentSeasonEnd { get; set; }

        [JsonProperty("currentSeasonId")]
        public int currentSeasonId { get; set; }

        [JsonProperty("nextSeasonStart")]
        public int nextSeasonStart { get; set; }
    }

    public class RANKEDTFTDOUBLEUP
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public object warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("currentSeasonEnd")]
        public long currentSeasonEnd { get; set; }

        [JsonProperty("currentSeasonId")]
        public int currentSeasonId { get; set; }

        [JsonProperty("nextSeasonStart")]
        public int nextSeasonStart { get; set; }
    }

    public class RANKEDTFTPAIRS
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public object warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("currentSeasonEnd")]
        public long currentSeasonEnd { get; set; }

        [JsonProperty("currentSeasonId")]
        public int currentSeasonId { get; set; }

        [JsonProperty("nextSeasonStart")]
        public int nextSeasonStart { get; set; }
    }

    public class RANKEDTFTTURBO
    {
        [JsonProperty("division")]
        public string division { get; set; }

        [JsonProperty("highestDivision")]
        public string highestDivision { get; set; }

        [JsonProperty("highestTier")]
        public string highestTier { get; set; }

        [JsonProperty("isProvisional")]
        public bool isProvisional { get; set; }

        [JsonProperty("leaguePoints")]
        public int leaguePoints { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("miniSeriesProgress")]
        public string miniSeriesProgress { get; set; }

        [JsonProperty("previousSeasonAchievedDivision")]
        public string previousSeasonAchievedDivision { get; set; }

        [JsonProperty("previousSeasonAchievedTier")]
        public string previousSeasonAchievedTier { get; set; }

        [JsonProperty("previousSeasonEndDivision")]
        public string previousSeasonEndDivision { get; set; }

        [JsonProperty("previousSeasonEndTier")]
        public string previousSeasonEndTier { get; set; }

        [JsonProperty("provisionalGameThreshold")]
        public int provisionalGameThreshold { get; set; }

        [JsonProperty("provisionalGamesRemaining")]
        public int provisionalGamesRemaining { get; set; }

        [JsonProperty("queueType")]
        public string queueType { get; set; }

        [JsonProperty("ratedRating")]
        public int ratedRating { get; set; }

        [JsonProperty("ratedTier")]
        public string ratedTier { get; set; }

        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonProperty("warnings")]
        public object warnings { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("currentSeasonEnd")]
        public long currentSeasonEnd { get; set; }

        [JsonProperty("currentSeasonId")]
        public int currentSeasonId { get; set; }

        [JsonProperty("nextSeasonStart")]
        public int nextSeasonStart { get; set; }
    }

    public class Root
    {
        [JsonProperty("earnedRegaliaRewardIds")]
        public List<object> earnedRegaliaRewardIds { get; set; }

        [JsonProperty("highestCurrentSeasonReachedTierSR")]
        public string highestCurrentSeasonReachedTierSR { get; set; }

        [JsonProperty("highestPreviousSeasonAchievedDivision")]
        public string highestPreviousSeasonAchievedDivision { get; set; }

        [JsonProperty("highestPreviousSeasonAchievedTier")]
        public string highestPreviousSeasonAchievedTier { get; set; }

        [JsonProperty("highestPreviousSeasonEndDivision")]
        public string highestPreviousSeasonEndDivision { get; set; }

        [JsonProperty("highestPreviousSeasonEndTier")]
        public string highestPreviousSeasonEndTier { get; set; }

        [JsonProperty("highestRankedEntry")]
        public HighestRankedEntry highestRankedEntry { get; set; }

        [JsonProperty("highestRankedEntrySR")]
        public HighestRankedEntrySR highestRankedEntrySR { get; set; }

        [JsonProperty("queueMap")]
        public QueueMap queueMap { get; set; }

        [JsonProperty("queues")]
        public List<Queue> queues { get; set; }

        [JsonProperty("rankedRegaliaLevel")]
        public int rankedRegaliaLevel { get; set; }

        [JsonProperty("seasons")]
        public Seasons seasons { get; set; }

        [JsonProperty("splitsProgress")]
        public SplitsProgress splitsProgress { get; set; }
    }

    public class Seasons
    {
        [JsonProperty("RANKED_FLEX_SR")]
        public RANKEDFLEXSR RANKED_FLEX_SR { get; set; }

        [JsonProperty("RANKED_SOLO_5x5")]
        public RANKEDSOLO5x5 RANKED_SOLO_5x5 { get; set; }

        [JsonProperty("RANKED_TFT")]
        public RANKEDTFT RANKED_TFT { get; set; }

        [JsonProperty("RANKED_TFT_DOUBLE_UP")]
        public RANKEDTFTDOUBLEUP RANKED_TFT_DOUBLE_UP { get; set; }

        [JsonProperty("RANKED_TFT_PAIRS")]
        public RANKEDTFTPAIRS RANKED_TFT_PAIRS { get; set; }

        [JsonProperty("RANKED_TFT_TURBO")]
        public RANKEDTFTTURBO RANKED_TFT_TURBO { get; set; }
    }

    public class SplitsProgress
    {
        [JsonProperty("1")]
        public int _1 { get; set; }
    }

    public class Warnings
    {
        [JsonProperty("daysUntilDecay")]
        public int daysUntilDecay { get; set; }

        [JsonProperty("demotionWarning")]
        public int demotionWarning { get; set; }

        [JsonProperty("displayDecayWarning")]
        public bool displayDecayWarning { get; set; }

        [JsonProperty("timeUntilInactivityStatusChanges")]
        public int timeUntilInactivityStatusChanges { get; set; }
    }
}