using System.Collections.Generic;

namespace TestKanban.Infrastructure.Models
{
    public interface IWorkItemModel
    {
        IWorkItemTypeModel @Type { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        int PercentageOfCompletion { get; set; }
        IEnumerable<IWorkItemModel> Prerequisites { get; set; }
        IResourceModel Resource { get; set; }
        IWorkItemStatusModel Status { get; set; }
        IEnumerable<IWorkItemTaskModel> Tasks { get; set; }
        string Title { get; set; }
    }
}