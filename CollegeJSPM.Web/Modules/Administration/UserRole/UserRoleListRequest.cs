using Serenity.Services;

namespace CollegeJSPM.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}