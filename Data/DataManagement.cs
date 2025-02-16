﻿using System;
using System.Collections.Generic;
using GatheringTimer.Data.Database;
using GatheringTimer.Data.Model;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using System.IO;
using System.Reflection;
using GatheringTimer.Data.Model.Entity;
using System.Threading;
using Autofac;
using GatheringTimer.Data.ThirdParty;
using GatheringTimer.Container;

namespace GatheringTimer.Data
{

    public interface IDataManagement:IDependency {
        
        Task<bool> Sync();

        void SyncCancel();

    }

    public class DataManagement:IDataManagement
    {
        private static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        public async Task<bool> Sync()
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 20;

            if (cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource = new CancellationTokenSource();
                GC.Collect();
            }
            if (await Container.Container.GetContainer().Resolve<IGatheringTimerResource>().SyncRaw(cancellationTokenSource.Token)) {
               return Container.Container.GetContainer().Resolve<IGatheringTimerResource>().CacheToData();
            }
            return false;
        }

        public void SyncCancel()
        {
            cancellationTokenSource.Cancel();
        }
    }

}