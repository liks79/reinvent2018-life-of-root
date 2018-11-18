using System.Collections.Generic;

namespace GotTalent_API.DTOs
{
    public class StageLogPostDTO
    {
        public int gameId { get; set; }
        public int stageId { get; set; }
    }

    public class StageLogPutDTO
    {
        public int game_id { get; set; }
        public int stage_id { get; set; }
        public int objects_score { get; set; }
        public int time_score { get; set; }
        public int total_score { get; set; }
        public string completed_yn { get; set; }
    }
}