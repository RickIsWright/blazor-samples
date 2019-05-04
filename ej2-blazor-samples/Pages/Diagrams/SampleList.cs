﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Diagram { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Shapes",
                Category = "Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Shapes",
                FileName = "Shapes.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Hierarchical tree",
                Category = "Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/HierarchicalModel",
                FileName = "HierarchicalModel.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Organization Chart",
                Category = "Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/OrganizationModel",
                FileName = "OrganizationModel.razor",
                Type = SampleType.New
            }
        };      
    }

   


}
