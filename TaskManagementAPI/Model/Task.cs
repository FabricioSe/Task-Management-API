using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Model
{
    public class Task
    {
        [Key]
        public string TaskUid { get; set; }

        [Required]
        public string CreatedByUid { get; set; }

        [Required]
        public string CreatedByName { get; set; }

        [Required]
        public string AssignedToUid { get; set; }

        [Required]
        public string AssignedToName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Done { get; set; }

        public Task(string createdByUid, string createdByName, string assignedToUid, string assignedToName, string description)
        {
            TaskUid = Guid.NewGuid().ToString();
            CreatedByUid = createdByUid;
            CreatedByName = createdByName;
            AssignedToUid = assignedToUid;
            AssignedToName = assignedToName;
            Description = description;
            Done = false;
        }

        public Task(string taskUid, string createdByUid, string createdByName, string assignedToUid, string assignedToName, string description, bool done)
        {
            TaskUid = taskUid;
            CreatedByUid = createdByUid;
            CreatedByName = createdByName;
            AssignedToUid = assignedToUid;
            AssignedToName = assignedToName;
            Description = description;
            Done = done;
        }

        public Task() { }
    }
}
