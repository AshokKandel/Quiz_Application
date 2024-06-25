namespace Quiz_Application.Utility
{
    public class SessionUtility
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionUtility(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetFromSession(string key)
        {
            string returnValue = "";
            if (_httpContextAccessor.HttpContext?.Session != null &&
                _httpContextAccessor.HttpContext.Session.GetString(key) != null)
            {
                returnValue = _httpContextAccessor.HttpContext.Session.GetString(key)?.ToString().Trim() ?? "";
            }
            return returnValue;
        }

        public string Name
        {
            get { return GetFromSession("Name"); }
            set { _httpContextAccessor.HttpContext.Session.SetString("Name", value); }
        }

        public string UserCode
        {
            get { return GetFromSession("UserCode"); }
            set { _httpContextAccessor.HttpContext.Session.SetString("UserCode", value); }
        }

        public string UserName
        {
            get { return GetFromSession("UserName"); }
            set { _httpContextAccessor.HttpContext.Session.SetString("UserName", value); }
        }
    }
}
