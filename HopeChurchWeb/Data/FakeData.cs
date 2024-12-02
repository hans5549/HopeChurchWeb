using HopeChurchWeb.Models;

namespace HopeChurchWeb.Data;

public class FakeData
{
    public List<UserMain> GetFormLogin()
    {
        return
        [
            new UserMain
            {
                Account = "黃芃銘", Email = "xiaoming.zhang@example.com", Password = "AAA", IsActive = true
            },
            new UserMain
            {
                Account = "張小明", Email = "xiaoming.zhang@example.com", Password = "hashed_password_001", IsActive = true
            },
            new UserMain
                { Account = "李美琪", Email = "meiqi.li@example.com", Password = "hashed_password_002", IsActive = true },
            new UserMain
            {
                Account = "王大華", Email = "dahua.wang@example.com", Password = "hashed_password_003", IsActive = true
            },
            new UserMain
            {
                Account = "陳佳佳", Email = "jiajia.chen@example.com", Password = "hashed_password_004", IsActive = false
            },
            new UserMain
            {
                Account = "林志偉", Email = "zhiwei.lin@example.com", Password = "hashed_password_005", IsActive = true
            },
            new UserMain
            {
                Account = "黃雅芳", Email = "yafang.huang@example.com", Password = "hashed_password_006", IsActive = true
            },
            new UserMain
            {
                Account = "劉建國", Email = "jianguo.liu@example.com", Password = "hashed_password_007", IsActive = true
            },
            new UserMain
            {
                Account = "吳淑芬", Email = "shufen.wu@example.com", Password = "hashed_password_008", IsActive = false
            },
            new UserMain
            {
                Account = "蔡明宏", Email = "minghong.tsai@example.com", Password = "hashed_password_009", IsActive = true
            },
            new UserMain
            {
                Account = "楊智敏", Email = "zhimin.yang@example.com", Password = "hashed_password_010", IsActive = true
            },
            new UserMain
            {
                Account = "周俊傑", Email = "junjie.zhou@example.com", Password = "hashed_password_011", IsActive = true
            },
            new UserMain
                { Account = "許雅婷", Email = "yating.xu@example.com", Password = "hashed_password_012", IsActive = true },
            new UserMain
            {
                Account = "鄭家豪", Email = "jiahao.zheng@example.com", Password = "hashed_password_013", IsActive = false
            },
            new UserMain
            {
                Account = "謝佳玲", Email = "jialing.xie@example.com", Password = "hashed_password_014", IsActive = true
            },
            new UserMain
            {
                Account = "宋志成", Email = "zhicheng.song@example.com", Password = "hashed_password_015", IsActive = true
            },
            new UserMain
                { Account = "賴怡君", Email = "yijun.lai@example.com", Password = "hashed_password_016", IsActive = true },
            new UserMain
            {
                Account = "徐志明", Email = "zhiming.xu@example.com", Password = "hashed_password_017", IsActive = false
            },
            new UserMain
            {
                Account = "葉俊宏", Email = "junhong.ye@example.com", Password = "hashed_password_018", IsActive = true
            },
            new UserMain
            {
                Account = "莊雅雯", Email = "yawen.zhuang@example.com", Password = "hashed_password_019", IsActive = true
            },
            new UserMain
            {
                Account = "潘建志", Email = "jianzhi.pan@example.com", Password = "hashed_password_020", IsActive = true
            },
            new UserMain
            {
                Account = "趙美玲", Email = "meiling.zhao@example.com", Password = "hashed_password_021", IsActive = true
            },
            new UserMain
            {
                Account = "蘇志豪", Email = "zhihao.su@example.com", Password = "hashed_password_022", IsActive = false
            },
            new UserMain
            {
                Account = "余佳蓉", Email = "jiarong.yu@example.com", Password = "hashed_password_023", IsActive = true
            },
            new UserMain
            {
                Account = "范志強", Email = "zhiqiang.fan@example.com", Password = "hashed_password_024", IsActive = true
            },
            new UserMain
            {
                Account = "朱雅芳", Email = "yafang.zhu@example.com", Password = "hashed_password_025", IsActive = true
            },
            new UserMain
            {
                Account = "唐建華", Email = "jianhua.tang@example.com", Password = "hashed_password_026", IsActive = false
            },
            new UserMain
            {
                Account = "曾淑英", Email = "shuying.zeng@example.com", Password = "hashed_password_027", IsActive = true
            },
            new UserMain
            {
                Account = "江志偉", Email = "zhiwei.jiang@example.com", Password = "hashed_password_028", IsActive = true
            },
            new UserMain
                { Account = "盧佳琪", Email = "jiaqi.lu@example.com", Password = "hashed_password_029", IsActive = true },
            new UserMain
            {
                Account = "梁家豪", Email = "jiahao.liang@example.com", Password = "hashed_password_030", IsActive = false
            },
            new UserMain
            {
                Account = "顏雅芳", Email = "yafang.yan@example.com", Password = "hashed_password_031", IsActive = true
            },
            new UserMain
            {
                Account = "馬志明", Email = "zhiming.ma@example.com", Password = "hashed_password_032", IsActive = true
            },
            new UserMain
            {
                Account = "尹佳玲", Email = "jialing.yin@example.com", Password = "hashed_password_033", IsActive = true
            },
            new UserMain
            {
                Account = "方建國", Email = "jianguo.fang@example.com", Password = "hashed_password_034", IsActive = false
            },
            new UserMain
                { Account = "何淑芬", Email = "shufen.he@example.com", Password = "hashed_password_035", IsActive = true },
            new UserMain
            {
                Account = "邱明宏", Email = "minghong.qiu@example.com", Password = "hashed_password_036", IsActive = true
            },
            new UserMain
            {
                Account = "湯智敏", Email = "zhimin.tang@example.com", Password = "hashed_password_037", IsActive = true
            },
            new UserMain
            {
                Account = "秦俊傑", Email = "junjie.qin@example.com", Password = "hashed_password_038", IsActive = false
            },
            new UserMain
            {
                Account = "任雅婷", Email = "yating.ren@example.com", Password = "hashed_password_039", IsActive = true
            },
            new UserMain
            {
                Account = "田家豪", Email = "jiahao.tian@example.com", Password = "hashed_password_040", IsActive = true
            },
            new UserMain
            {
                Account = "袁佳玲", Email = "jialing.yuan@example.com", Password = "hashed_password_041", IsActive = true
            },
            new UserMain
            {
                Account = "駱志成", Email = "zhicheng.luo@example.com", Password = "hashed_password_042", IsActive = false
            },
            new UserMain
                { Account = "巫怡君", Email = "yijun.wu@example.com", Password = "hashed_password_043", IsActive = true },
            new UserMain
            {
                Account = "彭志明", Email = "zhiming.peng@example.com", Password = "hashed_password_044", IsActive = true
            },
            new UserMain
            {
                Account = "傅俊宏", Email = "junhong.fu@example.com", Password = "hashed_password_045", IsActive = true
            },
            new UserMain
            {
                Account = "費雅雯", Email = "yawen.fei@example.com", Password = "hashed_password_046", IsActive = false
            },
            new UserMain
            {
                Account = "白建志", Email = "jianzhi.bai@example.com", Password = "hashed_password_047", IsActive = true
            },
            new UserMain
            {
                Account = "史美玲", Email = "meiling.shi@example.com", Password = "hashed_password_048", IsActive = true
            },
            new UserMain
                { Account = "齊志豪", Email = "zhihao.qi@example.com", Password = "hashed_password_049", IsActive = true },
            new UserMain
            {
                Account = "康佳蓉", Email = "jiarong.kang@example.com", Password = "hashed_password_050", IsActive = false
            }
        ];
    }
}