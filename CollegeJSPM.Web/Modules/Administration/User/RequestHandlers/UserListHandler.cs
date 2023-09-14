using Serenity.Services;
using MyRequest = CollegeJSPM.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<CollegeJSPM.Administration.UserRow>;
using MyRow = CollegeJSPM.Administration.UserRow;

namespace CollegeJSPM.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}