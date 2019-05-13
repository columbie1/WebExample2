using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;


namespace WebExample2.Module.BusinessObjects
{   [NavigationItem("Users Stuff")]
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty("Title")]
    public class Position : BaseObject
    {
        public Position(Session session) : base(session) { }
        private string title;
        [RuleRequiredField(DefaultContexts.Save)]
        public string Title
        {
            get { return title; }
            set { SetPropertyValue("Title", ref title, value); }
        }
        [Association("Position-Department")]
        public XPCollection<Department> Department
        {
            get
            {
                return GetCollection<Department>(nameof(Department));
            }
        }
    }
}