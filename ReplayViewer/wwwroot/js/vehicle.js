export function reorderEuler(euler) {
    euler.reorder('YXZ');
}

export function getObjectByName(obj, name) {
    if (obj.userData.treeName === name) {
        return obj;
    }
    
    for (let i = 0; i < obj.children.length; i++) {
        let child = obj.children[i];
        let found = getObjectByName(child, name);
        if (found) {
            return found;
        }
    }
    
    return null;
}