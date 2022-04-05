##7
**交互逻辑**：用户操作或其他输入造成的逻辑  
**表现逻辑**：model数据变化后，更新view  
总结：
*	表现逻辑 适合用 事件 或 委托
*	表现逻辑用方法调用会造成很多问题，Controller 臃肿难维护、
*	Model 和 View 是自底向上的关系
*	自底向上用事件或委托
*	自顶向下用方法调用
*	Event 工具类不能传参
*	BindableProperty 是 数据 + 数据变更事件，可以节省代码量

##9
总结：
*	交互逻辑 会有很多 会让 Controller 臃肿
*	很多 Unity 框架的交互逻辑是由 Command 实现的
*	Command 模式可以让逻辑的调用和执行在空间和时间上分离
*	Command 分担 Controller 的交互逻辑
*	struct 比 class 有更好的内存管理效率


##21 完善IController
为接口创建abstract子类。  将样板代码统一在虚类中实现，避免具体子类的重复使用