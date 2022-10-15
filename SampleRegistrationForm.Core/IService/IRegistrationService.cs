﻿using SampleRegistrationForm.Core.Model;
using SampleRegistrationForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRegistrationForm.Core.IService
{
   public interface IRegistrationService
    {
        void CreateMethod(RegistrationModel Registration);
        //void EditMethod(RegistrationModel model);
        RegistrationModel EditMethod(int id);
        List<RegistrationModel> ListMethod();
        void DeleteMethod(int Id);
    }
}
