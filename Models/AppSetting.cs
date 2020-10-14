namespace api1.Models
{
    public interface IAppSetting
    {
        string ProjectName { get; set; }
        string SmtpIp { get; set; }
    }

    public class AppSetting : IAppSetting
    {
        public string ProjectName { get; set; }
        public string SmtpIp { get; set; }
    }
}