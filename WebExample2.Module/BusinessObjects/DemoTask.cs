﻿using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;


namespace WebExample2.Module.BusinessObjects
{   [NavigationItem("Users Stuff")]
    [DefaultClassOptions]
    [ModelDefault("Caption", "Tareas")]
    public class DemoTask : Task
    {
        public DemoTask(Session session) : base(session) { }

        public override void AfterConstruction() {
        base.AfterConstruction();
        Priority =Priority.Normal;
          }
        [Association]
        public XPCollection<Contact> Contacts
        {
            get
            {
                return GetCollection<Contact>("Contacts");
            }
        }      
    

    private Priority priority;
    public Priority Priority {
        get { return priority; }
        set {
            SetPropertyValue("Priority", ref priority, value);
            }
      }
        [Action(ToolTip = "Postpone the task to the next day")]
         public void Postpone() {
        if(DueDate == DateTime.MinValue) {
            DueDate = DateTime.Now;
        }
        DueDate = DueDate + TimeSpan.FromDays(5);
    }
   }
    public enum Priority {
    [ImageName("State_Priority_Low")]
    Low = 0,
    [ImageName("State_Priority_Normal")]
    Normal = 1,
    [ImageName("State_Priority_High")]
    High = 2
}
 
    
    
    }
