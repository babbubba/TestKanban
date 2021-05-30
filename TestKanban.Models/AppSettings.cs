using System;
using TestKanban.Infrastructure;

namespace TestKanban.Models
{
    public class AppSettings : IAppSettings
    {
        public string MainFormTitle { get; set; }
    }
}
