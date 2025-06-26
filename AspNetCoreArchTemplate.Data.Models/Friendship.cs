namespace AspNetCoreArchTemplate.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class Friendship
    {  
        public string RequesterId { get; set; } = null!;
        public IdentityUser Requester { get; set; } = null!;
        public string AddresseeId { get; set; } = null!;
        public IdentityUser Addressee { get; set; } = null!;
        public FriendshipStatus Status { get; set; }

        public DateTime RequestedAt { get; set; }
        public DateTime? AcceptedAt { get; set; }
    }

    public enum FriendshipStatus
    {
        Pending,
        Accepted,
        Blocked,
        Rejected
    }
}
