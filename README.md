# doc2cls
根据奇门api文档生成C#实体</br>
NOTE：请确保文档中的xml是有效的，奇门发布文档时有多处xml结构不完整，请先行修改</br>
python版本是3.x
#Usage:
  python doc2cls_cs.py [arguments...]
#Arguments:
    --path  指定奇门文档的路径
    --nresolve  不从docx文档开始解析，直接从上次生成的xml文件生成实体，默认每次都从docx文档开始解析
    --attr  生成字段的校验特性，如必填字段[Required], string类型字段[MaxLength(50)]，默认不生成校验特性
#Demo:
    python doc2cls_cs.py --path D:/document/api.docx :从api.docx文档开始解析，并且不生成字段校验特性
    python doc2cls_cs.py --nresolve --attr :从已生成的xml文件开始解析，并且生成字段校验特性
