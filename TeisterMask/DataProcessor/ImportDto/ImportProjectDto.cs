using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Project")]
    public class ImportProjectDto
    {
        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("OpenDate")]
        public string OpenDate { get; set; }

        [XmlElement("DueDate")]
        public string DueDate { get; set; }

        [XmlArray("Tasks")]
        public List<ImportProjectTaskDtos> Tasks { get; set; }
    }

    [XmlType("Task")]
    public class ImportProjectTaskDtos
    {
        [Required]
        [XmlElement("Name")]
        [MinLength(2)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [XmlElement("OpenDate")]
        public string OpenDate { get; set; }

        [Required]
        [XmlElement("DueDate")]
        public string DueDate { get; set; }

        [Required]
        [XmlElement("ExecutionType")]
        [Range(0, 3)]
        public int ExecutionType { get; set; }

        [Required]
        [XmlElement("LabelType")]
        [Range(0, 4)]
        public int LabelType { get; set; }

    }

}
