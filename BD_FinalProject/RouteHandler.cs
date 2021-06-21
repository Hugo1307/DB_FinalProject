using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_FinalProject
{

    class RouteHandler
    {

        private static RouteHandler instance;
        private Stack<Route> programRoutes = new Stack<Route>();

        private RouteHandler() { }

        public static RouteHandler getInstance()
        {
            if (instance == null) 
                instance = new RouteHandler();
            return instance;
        }

        public void addRoute(Route screen)
        {
            programRoutes.Push(screen);
        }

        public UserControl getPreviousRoute()
        {
            if (programRoutes.Count > 0)
                return programRoutes.Pop().getNewInstance();
            return null;
        }

        public bool routeExists(RouteName routeName)
        {

            foreach (Route existentRoute in this.programRoutes)
            {
                if (existentRoute.getName() == routeName)
                {
                    return true;
                }
            }
                    
            return false;

        }

        public UserControl getRoute(RouteName routeName)
        {
            foreach (Route existentRoute in this.programRoutes)
            {
                if (existentRoute.getName() == routeName)
                {
                    return existentRoute.getNewInstance();
                }
            }
            return null;
        }

        public void showRoute(UserControl route)
        {
            Main mainForm = Main.getInstance();
            Panel routingPanel = (Panel) mainForm.Controls["P_MainRouting"];

            if (!(route is Route)) return;

            route.Parent = routingPanel;
            route.Location = new System.Drawing.Point(0, 0);
            route.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            route.BringToFront();
           
            this.addRoute((Route) route);

        }

    }

}
