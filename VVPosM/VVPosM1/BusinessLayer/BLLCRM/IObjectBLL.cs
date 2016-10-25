using System;
using System.Data;

namespace VVPosM1.BusinessLayer.BLLCRM
{
    interface IObjectBLL<T>
    {
        bool Add(T obj);
        bool Edit(T obj);
        bool Delete(String id);
        DataTable GetLists();
        T GetById(String id);
    }

    interface IBoolObjectBLL<T>
    {
        bool Add(T obj);
        bool Edit(T obj);
        bool Delete(String id);
        DataTable GetLists();
        T GetById(String id);
    }
}
