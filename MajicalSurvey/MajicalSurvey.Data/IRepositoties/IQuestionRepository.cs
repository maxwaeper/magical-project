﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajicalSurvey.Data
{
    public interface IQuestionRepository
    {
        List<Questions> GetAllQuestions();

       // Questions GetQuestionByName(string name);
    }
}
