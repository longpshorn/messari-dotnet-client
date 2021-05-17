using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class ConsensusAndEmissionsConsensus
    {
        [JsonProperty("consensus_details")]
        public string ConsensusDetails { get; set; }
        [JsonProperty("general_consensus_mechanism")] 
        public string GeneralConsensusMechanism { get; set; }
        [JsonProperty("precise_consensus_mechanism")] 
        public string PreciseConsensusMechanism { get; set; }
        [JsonProperty("targeted_block_time")] 
        public int TargetedBlockTime { get; set; }
        [JsonProperty("block_reward")] 
        public double BlockReward { get; set; }
        [JsonProperty("mining_algorithm")] 
        public string MiningAlgorithm { get; set; }
        [JsonProperty("next_halving_date")] 
        public DateTime NextHalvingDate { get; set; }
        [JsonProperty("is_victim_of_51_percent_attack")]
        public bool IsVictimOf51PercentAttack { get; set; }
    }
}