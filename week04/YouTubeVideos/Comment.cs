

namespace YouTubeVideos
{
    public class Comment
    {
        private string _commenter;
        private string _text;

        public Comment(string commenter, string text)
        {
            _commenter = commenter;
            _text = text;
        }

        public string GetCommentDetails()
        {
            return $"{_commenter}: {_text}";
        }
    }
}