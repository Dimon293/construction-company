using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ConstructionCompany.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ConstructionCompany.DataAdapters
{
    public class RuleDataAdapter : DataAdapter
    {
        private ObservableCollection<Rule> Rules;
        public RuleDataAdapter(MySqlConnection connection, ObservableCollection<Rule> rules) : base(connection)
        {
            Rules = rules;
        }

        private void Rules_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Add(e.NewItems[0] as Rule);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    this.Delete(e.OldItems[0] as Rule);
                    break;
            }
        }
        private void Object_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "WorkName" || e.PropertyName == "AttributeName" || e.PropertyName == "AttributeValue") this.Update(sender as Rule);
        }

        public void Fill()
        {
            Rules.CollectionChanged -= Rules_CollectionChanged;
            List<Dictionary<string, string>> allRules = GetQueryResult("select r.Id, w.WorkName, r.AttributeName, r.AttributeValue from Rule r left join Work w on r.IdWork=w.Id;");
            foreach (Dictionary<string, string> a in allRules)
            {
                Rule br = new Rule(long.Parse(a["Id"]), a["WorkName"], a["AttributeName"], int.Parse(a["AttributeValue"]));
                br.PropertyChanged += Object_PropertyChanged;
                Rules.Add(br);
            }
            Rules.CollectionChanged += Rules_CollectionChanged;
        }
        public void Add(Rule rule)
        {
            rule.PropertyChanged += Object_PropertyChanged;
            rule.Id = InsertRow($"insert into Rule (IdWork, AttributeName, AttributeValue) values ('{GetWorkId(rule.WorkName)}', '{rule.AttributeName}', '{rule.AttributeValue}');");
        }
        public void Delete(Rule rule)
        {
            Execute($"delete from Rule where Id={rule.Id}");
        }
        public void Update(Rule rule)
        {
            Execute($"update Rule set IdWork='{GetWorkId(rule.WorkName)}', AttributeName='{rule.AttributeName}', AttributeValue='{rule.AttributeValue}' where id={rule.Id};");
        }
        private long GetWorkId(string name)
        {
            foreach (Work w in DataModel.Works)
            {
                if (w.WorkName == name)
                    return w.Id;
            }
            return 0;
        }
    }
}
