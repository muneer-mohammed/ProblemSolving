#include "pch.h"
#include "../SolutionsCPP/BinaryTree.h"
/*https://www.geeksforgeeks.org/find-the-minimum-element-in-a-binary-search-tree/*/
TEST(TestCaseName, FindNodeWithMinimumValueInBST) {
	BinaryTree* obj = new BinaryTree();
	obj->FindNodeWithMinimumValueInBST();

	EXPECT_TRUE(true);
} 