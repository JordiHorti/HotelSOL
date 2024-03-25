using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IDAO<T>
{
    T GetById(int id);
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    IList<T> GetAll();
  
}

