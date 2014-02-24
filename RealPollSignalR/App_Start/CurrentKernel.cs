﻿using Ninject;
using RealPollSignalR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealPollSignalR.App_Start
{
    public class CurrentKernel
    {
        public static IKernel Current { get; set; }


        public static IKernel Init()
        {
            if (Current != null)
            {
                return Current;
            }

            Current = new StandardKernel();
            Current.Bind<IQuestionRepository>().To<FakeQuestionRepository>();

            return Current;
        }
    }
}