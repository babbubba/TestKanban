namespace TestKanban.Infrastructure.Models
{
    public interface IWorkItemTaskStatusModel
    {
        int Id { get; set; }
        string Code { get; set; }
        string Label { get; set; }
    }
}