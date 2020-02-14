using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingCosmos.models;

namespace TestingCosmos.Data
{
    public class ProcessHomeData
    {
        private readonly IConfiguration Config;

        public ProcessHomeData(IConfiguration config)
        {
            Config = config;
        }

        public HomeData SetHomeDataAwait()
        {
            HomeData homeData = new HomeData
            {
                ParentChildOne = Config["Parent:ChildOne"],
                ParentChildTwo = Config["Parent:ChildTwo"]
            };
            return homeData;
        }

        public Task<HomeData> GetHomeData()
        {
            return Task.FromResult(SetHomeDataAwait());
            
        }

       


    }
}
