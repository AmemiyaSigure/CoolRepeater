﻿using cx.rain.cq.coolrepeater.Code.Event;
using cx.rain.cq.coolrepeater.UI.Menu;
using Native.Sdk.Cqp.Interface;
using Unity;

namespace Native.Core
{
	/// <summary>
	/// 酷Q应用主入口类
	/// </summary>
	public class CQMain
	{
		/// <summary>
		/// 在应用被加载时将调用此方法进行事件注册, 请在此方法里向 <see cref="IUnityContainer"/> 容器中注册需要使用的事件
		/// </summary>
		/// <param name="container">用于注册的 IOC 容器 </param>
		public static void Register(IUnityContainer unityContainer)
		{
			unityContainer.RegisterType<IAppEnable, Event_AppEnable>("应用已被启用");
			unityContainer.RegisterType<IAppDisable, Event_AppDisable>("应用将被停用");
			unityContainer.RegisterType<IGroupMessage, Event_GroupMessage>("群消息处理");
			unityContainer.RegisterType<IDiscussMessage, Event_DiscussMessage>("讨论组消息处理");

			unityContainer.RegisterType<IMenuCall, Menu_Settings>("复读机选项");
		}
	}
}
