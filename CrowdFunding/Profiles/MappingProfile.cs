using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace CrowdFunding.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CampaignRequestDto, Campaign>();
            CreateMap<Campaign, CampaignResponsetDto>();

            CreateMap<DonationRequestDto, Donation>();
            CreateMap<Donation, DonationResponsetDto>();

            CreateMap<CommentRequestDto, Comment>();
            CreateMap<Comment, CommentResponsetDto>();
        }
    }
}
