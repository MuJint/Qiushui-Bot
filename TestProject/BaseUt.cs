﻿using Microsoft.Extensions.DependencyInjection;
using Qiushui.Framework.Interface;
using Qiushui.Framework.Services;

namespace TestProject
{
    public class BaseUt
    {
        readonly ServiceProvider provider = new ServiceCollection()
                .AddScoped<ILianChatServices, LianChatServices>()
                .AddScoped<ILianKeyWordsServices, LianKeyWordsServices>()
                .AddScoped<ISignLogsServices, SignLogsServices>()
                .AddScoped<ISignUserServices, SignUserServices>()
                .AddScoped<ISpeakerServices, SpeakerServices>()
            .BuildServiceProvider();
        protected T GetInstance<T>() => provider.GetService<T>();
    }
}
