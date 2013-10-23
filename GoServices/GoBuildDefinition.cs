using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SirenOfShame.Lib.Settings;

namespace GoServices
{
    public class GoBuildDefinition : MyBuildDefinition
    {
        private string _id;
        private string _name;

        public GoBuildDefinition(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string Id
        {
            get { return _id; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
