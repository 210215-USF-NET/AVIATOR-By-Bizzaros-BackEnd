﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AviModels
{
    public class File
    {
        public int ID { get; set; }
        public Pilot Pilot { get; set; }
        public int PilotID { get; set; }
        public User Uploader { get; set; }
        public int UploaderID { get; set; }
        public string FileURL { get; set; }
        public List<SceneFile> SceneFiles { get; set; }
    }
}
