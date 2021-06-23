using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{

    public class DataCache
    {

        private static DataCache instance;
        private List<Workspace> allUserWorkspaces;
        private User currentUser;
        private Workspace currentWorkspace;

        public List<Workspace> AllUserWorkspaces { get => allUserWorkspaces; set => allUserWorkspaces = value; }
        public User CurrentUser { get => currentUser; set => currentUser = value; }
        public Workspace CurrentWorkspace { get => currentWorkspace; set => currentWorkspace = value; }

        private DataCache() { }
       
        public static DataCache getInstance()
        {
            if (instance == null) instance = new DataCache();
            return instance;
        }

    }

}
