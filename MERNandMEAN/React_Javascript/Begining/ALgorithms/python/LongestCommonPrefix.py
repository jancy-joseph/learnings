def longestCommonPrefix(strs):
        """
        :type strs: List[str]
        :rtype: str
        """
        firstStr = strs[0];
        k = 0;
        longCommPrefixStr = "";
        for i in range(1,len(strs)): 
            print("i",i);
            for j in range(0, len(strs[i])):
                print("strs[i][j]",strs[i][j]);
                if strs[i][j] != firstStr[k]:
                    print("j",j);
                    if len(longCommPrefixStr) == 0:
                        longCommPrefixStr = strs[i][0:k];
                        print("longCommPrefixStr 1",longCommPrefixStr);
                        
                    else: 
                        newstr = strs[i][0:k];
                        if len(newstr) < len(longCommPrefixStr):
                            longCommPrefixStr=newstr;
                            print("longCommPrefixStr 2",longCommPrefixStr);

                    k=0;
                    break;
                k+=1;
                if j == len(strs[i])-1 and longCommPrefixStr =="":
                    longCommPrefixStr =  strs[i];
                    print("string has all same characters",longCommPrefixStr);                
        return longCommPrefixStr;



print(longestCommonPrefix(["flower","flow","flight"])); 