using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Relation
    {

        public RelationType relationType { get; set; }
        public enum RelationType
        {
            Sister, Brother, Mother, Father
        }

        public Relation(Person person01, Person person02, RelationType relationType)
        {
            this.relationType = relationType;
        }

        public string ShowRelationship(Person person01, Person person02, RelationType relationType)
        {
            return $"Relationship between {person01.firstName} and {person02.firstName} is: {relationType}hood \n";
        }
    }
}
