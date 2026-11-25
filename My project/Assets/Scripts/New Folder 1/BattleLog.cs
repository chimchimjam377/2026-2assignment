using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };  //이게 0,1,2,3,4,5 순서대로 있는 거잖아 음.. 칸 수는 6이군
    // 이거 불러오는 방식이... for 해서 조건 쪽에 Length 하면 되는 거겠군.. for 로하면 쉬운거 아닌감..
    // 이런.. foreach로 총데미지를 구해야하네.. 잠시 공부
    // 아니 foreach가 이름을 담은걸 출력하는 변수네..? 그럼 뭐지...혼란.. 아 줄별로 담아두는거구나 3개 담아두면 3줄로 출력되고 그런식 아하
    // foreach 이녀석 값을 바로 받는다고? 범위를 잘못 쓸 일이 없다고?? 좋은데?
    public int criticalLine = 3000;  // 3000 이상이면 크리티컬로 분류하라는거군...

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int totaldamage = 0;

        List<int> criticals = new List<int>();

        foreach (int damage in damages)
        {
            totaldamage += damage;

            if(damage >= criticalLine)
            {
                criticals.Add(damage);
            }

        }
        Debug.Log("총 가한 데미지 : " + totaldamage + "( 때린 횟수 : " + damages.Length + "회 )");

        //이렇게 하면 총 데미지 출력 되겠지
        // 치명타 횟수 해야하는데.. 조건에 List<int> criticals 로 하라네..? 줄 횟수로는 fdreach 로 출력 하면 되겠고..
        // List 출력 코딩 할 때 여러가지 게임 오브젝트 넣기 좋아서 신이라고 찬양했던 기억이..
        // List 해서 저 criticalLine 이 3000이라고 했으니 데미지의 배열이 3000 이상인 값만 받아오게 하면 되겠군...
        //젠장 근데 수식이 안 떠올라!! 음.. 3000 미만은 지워 버리면 되는건가..?그러고 출력하고? 아니면 dmages에서 3000 이상인것반 받아오게 하거나
        // 지피티가 이번 과제에서는 첫번째 방법을 추천한데.. 아 여기 주석에는 반대구나
        // if와 add를 사용해서라..

        //으아 많은 걸 틀리고 고쳤다..

        Debug.Log("치명타 " + criticals.Count + " 회");

        foreach (int critical in criticals)
        {
            
            Debug.Log("치명타" + critical);
        }



    }







}
