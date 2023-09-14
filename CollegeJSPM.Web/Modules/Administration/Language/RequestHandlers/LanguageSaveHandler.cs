using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CollegeJSPM.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CollegeJSPM.Administration.LanguageRow;


namespace CollegeJSPM.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}