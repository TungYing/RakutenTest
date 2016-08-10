/**
	暴力法
	foreach subBoard in board :  
	 foreach node in subBoard :
		if node的第一個字元是否跟word的第一個字元一樣: 
			if( findNext(node) == true)
				return ture;
	return false;
			
	function findNext(board,currentNode, row, col,word): 
		每一個node會經由上下左右四個方向去找尋是否有此字串，使用遞迴

**/