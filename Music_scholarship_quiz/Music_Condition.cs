using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_scholarship_quiz
{
    class Music_Condition
    {
        public string Condition(string path)
        {
            string result = "";

            if (path.Contains("천생연분"))
            {
                result = "속이는 소개팅";
            } else if (path.Contains("T.O.P"))
            {
                result = "백조의 호수";
            } else if (path.Contains("Poison"))
            {
                result = "김종민 백댄서";
            } else if (path.Contains("어머님께"))
            {
                result = "효도";
            } else if (path.Contains("순정"))
            {
                result = "코끼리";
            } else if (path.Contains("캔디"))
            {
                result = "달콤한";
            } else if (path.Contains("I`m Your Girl"))
            {
                result = "요정";
            } else if (path.Contains("잘못된 만남"))
            {
                result = "바람났어";
            } else if (path.Contains("이정현"))
            {
                result = "테크노";
            } else if (path.Contains("검은 고양이"))
            {
                result = "네로";
            } else if (path.Contains("Lonely Night"))
            {
                result = "벌쳐";
            } else if (path.Contains("이미 슬픈 사랑"))
            {
                result = "남자 노래방 금지곡";
            } else if (path.Contains("천년의 사랑"))
            {
                result = "구미호";
            } else if (path.Contains("말달리자"))
            {
                result = "닥쳐";
            } else if (path.Contains("내 남자 친구에게"))
            {
                result = "소녀의 고백";
            } else if (path.Contains("사랑해 그리고 기억해"))
            {
                result = "국민 아이돌";
            } else if (path.Contains("실연"))
            {
                result = "2글자 히트곡";
            } else if (path.Contains("Storm"))
            {
                result = "나이트 클럽";
            } else if (path.Contains("고백"))
            {
                result = "친구에서 연인으로";
            } else if (path.Contains("트위스트킹"))
            {
                result = "근육질 보컬";
            } else if (path.Contains("헤어진 후에"))
            {
                result = "밀레니엄 버그";
            }else if (path.Contains("무기여 잘 있거라"))
            {
                result = "비참한 연애";
            }else if (path.Contains("난 괜찮아"))
            {
                result = "리메이크 곡";
            }else if (path.Contains("헤어진 다음날"))
            {
                result = "TV 조명시간";
            }else if (path.Contains("산다는건 다 그런게 아니겠니"))
            {
                result = "동창회";
            }else if (path.Contains("비행기"))
            {
                result = "어릴적 꿈";
            }else if (path.Contains("Tell me"))
            {
                result = "어머나";
            }else if (path.Contains("전진"))
            {
                result = "빠삐놈 + 뮤탈춤";
            }else if (path.Contains("친구여"))
            {
                result = "학창시절 그 이후";
            }else if (path.Contains("낭만고양이"))
            {
                result = "생선";
            }else if (path.Contains("오아시스"))
            {
                result = "현재 이 상황";
            }else if (path.Contains("8282"))
            {
                result = "발라드와 댄스 사이";
            }else if (path.Contains("하루하루"))
            {
                result = "무한도전";
            }else if (path.Contains("박하사탕"))
            {
                result = "대표님 애창곡";
            }else if (path.Contains("다짐"))
            {
                result = "자켓";
            }else if (path.Contains("남자를 몰라"))
            {
                result = "쌈자";
            }else if (path.Contains("서커스"))
            {
                result = "유랑단";
            }else if (path.Contains("활주"))
            {
                result = "나루토";
            }else if (path.Contains("Gee"))
            {
                result = "전기";
            }else if (path.Contains("흔들린 우정"))
            {
                result = "친구야 미안해";
            }else if (path.Contains("Monster"))
            {
                result = "대표님";
            }else if (path.Contains("HUG"))
            {
                result = "아카펠라";
            }else if (path.Contains("다시만난세계"))
            {
                result = "소녀들의 시작";
            }else if (path.Contains("해바라기"))
            {
                result = "선글라스";
            }else if (path.Contains("Pretty Girl"))
            {
                result = "위풍 당당";
            }else if (path.Contains("몽환의숲"))
            {
                result = "이루마";
            }else if (path.Contains("유혹의 소나타"))
            {
                result = "국민차";
            }else if (path.Contains("헤어지지 못하는 여자, 떠나가지 못하는 남자"))
            {
                result = "미련";
            }else if (path.Contains("너의결혼식"))
            {
                result = "막장";
            }else if (path.Contains("Love Love Love"))
            {
                result = "샤인폰";
            }else if (path.Contains("내가 제일 잘 나가"))
            {
                result = "투비웨어 대표곡이 될 예정";
            }else if (path.Contains("위아래"))
            {
                result = "Up Down";
            }else if (path.Contains("강남스타일"))
            {
                result = "말춤";
            }else if (path.Contains("좋은 날"))
            {
                result = "3단고음";
            }else if (path.Contains("밥만 잘 먹더라"))
            {
                result = "이별했다고 죽지않아";
            }else if (path.Contains("All For You"))
            {
                result = "응답하라 1997";
            }else if (path.Contains("금요일에 만나요"))
            {
                result = "불금의 설레임";
            }else if (path.Contains("쿨하지못해 미안해"))
            {
                result = "찌질한 남자";
            }else if (path.Contains("언제나"))
            {
                result = "슈퍼스타 K";
            }else if(path.Contains("결혼까지 생각했어"))
            {
                result = "파혼";
            }else if (path.Contains("어디에도"))
            {
                result = "유튜브 커버 대표곡";
            }else if (path.Contains("광화문에서"))
            {
                result = "서울에 있음";
            }else if (path.Contains("썸 탈꺼야"))
            {
                result = "연애 전";
            }else if (path.Contains("Give Love"))
            {
                result = "남매듀오";
            }else if (path.Contains("자니"))
            {
                result = "추태";
            }else if (path.Contains("사뿐사뿐"))
            {
                result = "고양이";
            }else if (path.Contains("CHEER UP"))
            {
                result = "힘내";
            }else if (path.Contains("I Like That"))
            {
                result = "찜";
            }else if (path.Contains("LOVE DAY"))
            {
                result = "남녀 맞짱노래";
            }else if (path.Contains("오늘부터 우리는"))
            {
                result = "꽈당";
            }else if (path.Contains("그런 남자"))
            {
                result = "본인의 능력대로";
            }else if (path.Contains("민초의 난"))
            {
                result = "추노";
            }else if (path.Contains("우리집을 못 찾겠군요"))
            {
                result = "술 만취";
            }else if (path.Contains("우주를 줄게"))
            {
                result = "삼성 핸드폰";
            }else if (path.Contains("말해! 뭐해"))
            {
                result = "유대위";
            }

            return result;
        }
    }
}
