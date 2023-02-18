
namespace LessonsBotDbProvider.ServiceModels
{
    public struct ActionResult
    {
        public ActionCodeResult Code { get; set; }
        public string Message { get; set; }


        public ActionResult(ActionCodeResult code, string? msg)
        {
            Code = code;
            Message = msg;
        }
    }
}
