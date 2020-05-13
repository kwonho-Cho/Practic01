using System;

namespace LearnCS5
{
    class Person
    {
        string _Name;
        public bool _IsSex;

        string _txtGender;

        //생성자 초깃값
        public Person()
        {
            //Console.WriteLine("생성자가 호출 되었습니다!!");
            _Name = "홍길동";
            _IsSex = true;
            SettingGenderText(_IsSex);
        }

        //생성자 초기화
        public Person(string name, bool gender)
        {
            _Name = name;
            _IsSex = gender;
            SettingGenderText(_IsSex);
        }
        //stack메모리는 보통 cpu프로세스당 1mb, 스레드당 1mb.
        //가비지컬렉터는 사용되지않는 스택메모리를 제거하며 참조하고있는 힙메모리도 같이 제거한다
        //가비지컬렉터는 3개의 세대를 가지고, 0세대 -> 1세대 -> 2세대 메모리순으로 적재가 완료될시 정보를 제거 및 이동시킨다.

        //소멸자는 소멸을 하면서 어떤 정보를 넘겨줘야할 때 이용한다
        ~Person()
        {
            Console.WriteLine("소멸자가 호출 되었습니다.");
        }

        //설정 함수(초기화 이후 개별 변수의 설정을 변화시킬때)
        private void SettingGenderText(bool gender)
        {
            if (gender)
            {
                _txtGender = "남자";
            }
            else
            {
                _txtGender = "여자";
            }
        }

        //초기화 함수(변수 다수의 값을 초기화할떄)
        public void InitData(string name, bool gender)
        {
            _Name = name;
            _IsSex = gender;

            //gender변수가 반복해서 쓰일경우 받아오는 부분에서 결정시켜준다

            SettingGenderText(_IsSex);
            //if (_IsSex)
            //{
            //    _txtGender = "남자";
            //}
            //else
            //{
            //    _txtGender = "여자";
            //}
        }
        //외부에서 이름 설정
        public void SetName(string name)
        {
            _Name = name;
        }
        //외부에 이름 반환 (get, set 논리)
        public string GetName()
        {
            return _Name;
        }

        public void SetGender(bool gender)
        {
            _IsSex = gender;
            SettingGenderText(gender);
        }
        //gender의 형식인 bool값과 string값을 둘 다 원할 때 가져오기 위함
        public bool GetGender()
        {
            return _IsSex;
        }
        public string GetGenderText()
        {
            return _txtGender;
        }

        public void ShowInfo()
        {
            Console.WriteLine("내 이름은 {0}입니다.",_Name);
            Console.WriteLine("{0}입니다", _txtGender);
            
        }

        public void Laugh()
        {
            if (_IsSex)
            {
                Console.WriteLine("하하하");
            }
            else
            {
                Console.WriteLine("호호호");
            }
        }
    }
}
