﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
//using System.ServiceModel.Web;
using System.Text;
using System.IO;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.


[ServiceContract]
public interface ISAM
{

  [OperationContract]
  string GetData(int value);

  [OperationContract]
  string GetString(string str);

}