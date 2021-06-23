using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{
    public enum ActionType
    {
        ChangeVisibility,
        Consult,
        Upload,
        None
    }

    public static class ActionTypeMethods
    {
        public static ActionType convert(String typeStr)
        {
            foreach (ActionType actionType in Enum.GetValues(typeof(ActionType)))
            {
                if (actionType.ToString() == typeStr) return actionType;
            }

            return ActionType.None;

        }

    }

    public class Action
    {

        private int id;
        private string user;
        private DateTime date;
        private ActionType type;

        public Action(int id, string user, DateTime date, ActionType type)
        {
            this.id = id;
            this.user = user;
            this.date = date;
            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string User { get => user; set => user = value; }
        internal ActionType Type { get => type; set => type = value; }
    }
}
