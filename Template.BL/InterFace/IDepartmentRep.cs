using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.BL.Models;

namespace Template.BL.InterFace
{
    public interface IDepartmentRep
    {
        IEnumerable<DepartmentVM> Get();
        DepartmentVM getById (int Id);
        void create(DepartmentVM model);
        void update(DepartmentVM model);
        void Delete (int Id);
    }
}
