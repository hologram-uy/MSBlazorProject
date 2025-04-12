namespace EventEase
{
    public class UserSessionService
    {
        public string? UserName { get; private set; }

        public void SetUser(string name)
        {
            UserName = name;
        }

        public void Clear()
        {
            UserName = null;
        }

        public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);
    }
}
