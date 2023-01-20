namespace CommentR.Models
{
    public class CommentVM
    {
        public Guid ID { get; set; }
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid OriginalID { get; set; }

        public Guid CreatorId { get; set; }

    }
}