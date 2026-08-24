using CZGL.AOP;

namespace Demo2.AopLog
{
    //这个类允许被代理
    [Interceptor]
	public class Hello
	{
        //这个方法需要记录日志
        [Log]
		public virtual string SayHello(string content)
		{
			var str = $"Hello,{content}";
			return str;
		}
	}
}
