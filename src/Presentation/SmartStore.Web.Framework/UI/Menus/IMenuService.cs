﻿using System.Web.Mvc;
using SmartStore.Collections;

namespace SmartStore.Web.Framework.UI
{
    public partial interface IMenuService // INFO: replaces ISiteMapService
	{
		IMenu GetMenu(string name);
		TreeNode<MenuItem> GetRootNode(string menuName);
		TreeNode<MenuItem> GetCurrentNode(string menuName, ControllerContext controllerContext);
		void ResolveElementCounts(string menuName, TreeNode<MenuItem> curNode, bool deep = false);
		void ClearCache(string menuName);

        /// <summary>
        /// Registers actions to render user menus in widget zones.
        /// </summary>
        void ProcessMenus();
    }
}
