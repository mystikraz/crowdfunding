using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CommentResponsetDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public Guid CampaignId { get; set; }

    }
}
