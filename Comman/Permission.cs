using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    public class Permission
    {
        public static void AddPermission(ref PermissionItems current, params PermissionItems[] PermissionToAdd)
        {
            foreach (PermissionItems item in PermissionToAdd)
            {
                current |= item;
            }
        }

        public static void RemovePermission(ref PermissionItems current, params PermissionItems[] PermissionToRemove)
        {
            foreach (PermissionItems item in PermissionToRemove)
            {
                current &= ~item;
            }
        }

        public static bool CheckPermission(PermissionItems current, PermissionItems PermissionToCheck)
        {
            return ((current & PermissionToCheck) == PermissionToCheck);
        }
    }

    [Flags] //data annotation (decrator) => lear new behavior
    public enum PermissionItems : byte //int // 4 byte => 4 *  8 bit => 32
    {
        write = 1,
        read = 2,
        update = 4,
        delete = 8,
        execute = 16,
        select = 32,
        select1 = 64,
        select2 = 128,
    }
}
