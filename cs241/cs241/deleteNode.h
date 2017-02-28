void BST::BST_Erase(int item)
{
    // Call Erase Recursive Function
    BST_Erase(root, item);
}

// Pre-Con: Root and item passed as parameters
// Post-Con: Item is deleted from the tree
void BST::BST_Erase(Node* n, int item)
{
    // Find the item
    bool found = false;
    Node* predecessor=nullptr;
    Node* current=n;
    if(current==nullptr)
        cout<<"Tree is empty"<<endl;return;
    while(current!=nullptr)
    {
        if(current->data==item)
        {
            found = true;
            break;
        }
        else
        {
            predecessor = current;
            if(item > (current->data))
                current=current->right;
            else
                current=current->left;
        }
    }
    if(!found)
    {
        cout<<item<<" not in Tree."<<endl;
        return;
    }
    // CASE 1: Removing a node with a single child
    if((current->left==nullptr && current->right != nullptr) || (current->left != nullptr && current->right==nullptr))
    {
        // Right Leaf Present, No Left Leaf
        if(current->left==nullptr && current->right != nullptr)
        {
            // If predecessor's left tree equals Node n
            if(predecessor->left==current)
            {
                // then predecessor's left tree becomes n's right tree
                // and delete n
                predecessor->left=current->right;
                delete current;
                current=nullptr;
                cout<<item<<" has been removed from the Tree."<<endl;
            }
            // If predecessor's right tree equals Node n
            else
            {
                // then predecessor's right tree becomes n's right tree
                // and delete n
                predecessor->right=current->right;
                delete current;
                current=nullptr;
                cout<<item<<" has been removed from the Tree."<<endl;
            }
        }
        else // Left Leaf Present, No Right Leaf Present
        {
            if(predecessor->left==current)
            {
                predecessor->left=current->left;
                delete current;
                current=nullptr;
                cout<<item<<" has been removed from the Tree."<<endl;
            }
            else
            {
                predecessor->right=current->left;
                delete current;
                current=nullptr;
                cout<<item<<" has been removed from the Tree."<<endl;
            }
        }
        return;
    }
    // CASE 2: Removing a Leaf Node
    if(current->left==nullptr && current->right==nullptr)
    {
        if(predecessor->left==current)
            predecessor->left=nullptr;
        else
            predecessor->right=nullptr;
        delete current;
        cout<<item<<" has been removed from the Tree."<<endl;
        return;
    }
    // CASE 3: Node has two children
    // Replace Node with smallest value in right subtree
    if(current->left != nullptr && current->right != nullptr)
    {
        Node* check=current->right;
        if((current->left==nullptr)&&(current->right==nullptr))
        {
            current=check;
            delete check;
            current->right==nullptr;
            cout<<item<<" has been removed from the Tree."<<endl;
        }
        else // Right child has children
        {
            // If the node's right child has a left child
            // Move all the way down left to locate smallest element
            if((current->right)->left!=nullptr)
            {
                Node* leftCurrent;
                Node* leftCurrentPred;
                leftCurrentPred=current->right;
                leftCurrent=(current->right)->left;
                while(leftCurrent->left != nullptr)
                {
                    leftCurrentPred=leftCurrent;
                    leftCurrent=leftCurrent->left;
                }
                current->data=leftCurrent->data;
                delete leftCurrent;
                leftCurrentPred->left==nullptr;
                cout<<item<<" has been removed from the Tree."<<endl;
            }
            else
            {
                Node* temp=current->right;
                current->data=temp->data;
                current->right=temp->right;
                delete temp;
                cout<<item<<" has been removed from the Tree."<<endl;
            }
        }
        return;
    }
}