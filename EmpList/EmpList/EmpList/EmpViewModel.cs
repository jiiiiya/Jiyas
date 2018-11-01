using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EmpList
{
	public class EmpViewModel : ContentView
	{
        // Collection의 변화(Add/Delete)를 자동으로 감지하여 UI화면을 자동갱신
        // ObservableCollection은 INotyfyChanged 인터페이스를 구현했다.
        // ListView를 자동으로 업데이트 하기위해 ObservableCollection을 사용.
        private ObservableCollection<Emp> emps = new ObservableCollection<Emp>();
        public ObservableCollection<Emp> Emps
        {
            get
            {
                return emps;
            }
            set
            {
                emps = value;
            }
        }
        public EmpViewModel()
        {
            Emps = new ObservableCollection<Emp>();
        }
	}
}