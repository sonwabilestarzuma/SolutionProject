using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Common.AutoMapping.Repository
{

    public interface IHaveCustomMapping
    {
        void ConfigureMapping(Profile mapper);
    }
}