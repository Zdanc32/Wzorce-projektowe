using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Założenia Singletona
///     - nie da się utworzyć nowego obiektu klasy, bowiem inny został już utworzony
///     - Gdyby udało się tworzyć obiekt klasy należy zwracać referencje do istniejącego już obiektu
/// Po co to robimy?
///     - Zabezpiecznie przed duplikowaniem obiektów
///     - Zabezpiecznie swiata gry przed przypadkowym wygenerowaniem drugiego takiego samego tylko, że nowego
///     - Gdy chcemy by istniał tylko i wyłącznie jeden obiekt tej klasy ale potrzebujemy w innych miejscach w kodzie się odnosić do niego/// 
/// </summary>
namespace Wzorce_projektowe.Singleton
{
    public sealed class SerwerSingletonLocks
    {
        private static SerwerSingletonLocks m_oInstance = null;
        private int m_nCounter = 0;

        public static SerwerSingletonLocks Instance
        {
            get
            {
                if (m_oInstance == null)
                {
                    m_oInstance = new SerwerSingletonLocks();
                }
                return m_oInstance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Serwer po raz {0}!", m_nCounter++);
        }

        private SerwerSingletonLocks()
        {
            m_nCounter = 1;
        }

    }
}
